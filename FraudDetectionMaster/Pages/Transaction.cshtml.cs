using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FraudDetectionMaster.Data;
using FraudDetectionMaster.Models;

namespace FraudDetectionMaster.Pages;

    public class TransactionModel : PageModel
    {
        private readonly FraudDetectionMasterContext _context;

        public TransactionModel(FraudDetectionMasterContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get;set; } = default!;

            
        
        public async Task OnGetAsync()
        {
            if (_context.Transactions != null)
            {
                Transaction = await _context.Transactions.ToListAsync();
                
                
            }
        
    }
    }

