using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum EType { Male, Female };
    public enum EHMO { Maccabi, leumit, Meuchdet, Clalit };
    public class User
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public EType Type { get; set; }
        public EHMO HMo { get; set; }

    }
}
