using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MucleTherapyMVC.Web.Identity;
using StructureMap.Configuration.DSL;

namespace MucleTherapyMVC.Web.Infrastructure
{
    public class IdenityRegistry : Registry
    {
        public IdenityRegistry()
        {
            For<MuscleTherapyUser>().Use<MuscleTherapyUser>();

            For<IUserStore<MuscleTherapyUser>>().Use<MuscleTherapyUserStore>();
        }
    }
}