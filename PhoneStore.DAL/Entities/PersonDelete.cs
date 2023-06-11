using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.DAL.Entities
{
    public class PersonDelete
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<AddressDelete> EmailAddresse { get; set; }  = new List<AddressDelete>();
        public List<EmailDelete> EmailAddresses { get; set; } = new List<EmailDelete>();  
    }
}
