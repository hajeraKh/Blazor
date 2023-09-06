using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMasterDetails.Shared.DTO
{
    public class TestDTO
    {
        public int TestId { get; set; }
        public string? TestName { get; set; } = default!;
        public bool CanDelete { get; set; }
    }
}
