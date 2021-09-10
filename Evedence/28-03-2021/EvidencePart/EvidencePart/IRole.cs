using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePart
{
    public interface IRole
    {
        void AddRole(string Role);
        string RolePlay();
    }
}
