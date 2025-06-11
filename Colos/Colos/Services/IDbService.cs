﻿using WebApplication1.DTOs;

namespace WebApplication1.Services;

public interface IDbService
{
    Task<GetCharacterDto> GetCharacterByIdAsync(int id);
}