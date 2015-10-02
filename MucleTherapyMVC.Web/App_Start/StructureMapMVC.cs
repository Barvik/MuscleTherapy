using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MucleTherapyMVC.Common.Infrastructure;
using MucleTherapyMVC.Web.Infrastructure;
using StructureMap;

namespace MucleTherapyMVC.Web.App_Start
{
    public static class StructureMapMVC
    {
        public static void Start()
        {
            StructureMapBootstrapper.Initialize();
            DependencyResolver.SetResolver(new StructureMapContainer(ObjectFactory.Container));
        }
    }
}