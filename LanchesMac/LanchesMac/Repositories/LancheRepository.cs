﻿using LanchesMac.context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILanchesRepository
    {
        private readonly AppDbContext _context; 
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;

        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(o=>o.IsLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l=>l.LancheId==lancheId);
        }
    }
}

