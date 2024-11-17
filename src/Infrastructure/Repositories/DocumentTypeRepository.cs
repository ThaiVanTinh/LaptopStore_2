﻿using LaptopStore_2.Application.Interfaces.Repositories;
using LaptopStore_2.Domain.Entities.Misc;

namespace LaptopStore_2.Infrastructure.Repositories
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly IRepositoryAsync<DocumentType, int> _repository;

        public DocumentTypeRepository(IRepositoryAsync<DocumentType, int> repository)
        {
            _repository = repository;
        }
    }
}