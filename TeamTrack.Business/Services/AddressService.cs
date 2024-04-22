﻿using AutoMapper;
using FluentValidation;
using TeamTrack.Business.Validation;
using TeamTrack.Common.Dtos.Address;
using TeamTrack.Common.Interfaces;
using TeamTrack.Common.Model;

namespace TeamTrack.Business.Services;

public class AddressService : IAddressService
{
    private IMapper Mapper { get; }
    private IGenericRepository<Address> AddressRepository { get; }
    private AddressCreateValidator AddressCreateValidator { get; }
    private AddressUpdateValidator AddressUpdateValidator { get; }

    public AddressService(IMapper mapper, IGenericRepository<Address> addressRepository,
        AddressCreateValidator addressCreateValidator, AddressUpdateValidator addressUpdateValidator)
    {
        Mapper = mapper;
        AddressRepository = addressRepository;
        AddressCreateValidator = addressCreateValidator;
        AddressUpdateValidator = addressUpdateValidator;
    }


    public async Task<int> CreateAddressAsync(AddressCreate addressCreate)
    {
        await AddressCreateValidator.ValidateAndThrowAsync(addressCreate);

        var entity = Mapper.Map<Address>(addressCreate);
        await AddressRepository.InsertAsync(entity);
        await AddressRepository.SaveChangesAsync();
        return entity.Id;
    }

    public async Task DeleteAddressAsync(AddressDelete addressDelete)
    {
        var entity = await AddressRepository.GetByIdAsync(addressDelete.Id);
        AddressRepository.Delete(entity);
        await AddressRepository.SaveChangesAsync();
    }

    public async Task<AddressGet> GetAddressAsync(int id)
    {
        var entity = await AddressRepository.GetByIdAsync(id);
        return Mapper.Map<AddressGet>(entity);
    }

    public async Task<List<AddressGet>> GetAddressesAsync()
    {
        var entities = await AddressRepository.GetAsync(null, null);
        return Mapper.Map<List<AddressGet>>(entities);
    }

    public async Task UpdateAddressAsync(AddressUpdate addressUpdate)
    {
        await AddressUpdateValidator.ValidateAndThrowAsync(addressUpdate);

        var entity = Mapper.Map<Address>(addressUpdate);
        AddressRepository.Update(entity);
        await AddressRepository.SaveChangesAsync();
    }
}
