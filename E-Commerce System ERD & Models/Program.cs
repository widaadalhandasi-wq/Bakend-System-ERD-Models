using E_Commerce_System_ERD___Models.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.Threading.Channels;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.WebRequestMethods;

namespace E_Commerce_System_ERD___Models
{
    internal class Program
    {

        // Static in-memory context — accessible by all functions without passing parameters
        public static E_CommerceContext context = new E_CommerceContext();



    }
}
