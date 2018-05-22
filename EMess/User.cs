using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMess
{
    public enum EUserType
    {
        RegularUser,
        ManagerUser,
        AdminUser,
    }

    public abstract class IUser
    {
        public abstract EUserType GetType();
    }

    public class RegularUser : IUser
    {
        public override EUserType GetType()
        {
            return EUserType.RegularUser;
        }
    }

    public class ManagerUser : IUser
    {
        public override EUserType GetType()
        {
            return EUserType.ManagerUser;
        }
    }

    public class AdminUser : IUser
    {
        public override EUserType GetType()
        {
            return EUserType.AdminUser;
        }
    }
}
