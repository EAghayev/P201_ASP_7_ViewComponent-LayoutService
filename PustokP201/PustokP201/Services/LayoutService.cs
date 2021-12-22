using Microsoft.EntityFrameworkCore;
using PustokP201.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokP201.Services
{
    public class LayoutService
    {
        private readonly PustokContext _context;

        public LayoutService(PustokContext context)
        {
            _context = context;
        }
        public async Task<List<Setting>> GetSettings()
        {
            return await _context.Settings.ToListAsync();
        }
    }
}
