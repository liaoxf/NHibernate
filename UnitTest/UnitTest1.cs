using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services.Services;
using Services;
using Services.Core;
using Autofac;
using Newtonsoft.Json;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        ContainerBuilder builder = new ContainerBuilder();

        public IContainer init()
        {
            builder.RegisterType<Service>().As<IServices>();
            return builder.Build();
        }

        [TestMethod]
        public void TestMethod1()
        {
            IServices service = new Service();
            var result = service.GetMenus();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var container = init();
            var serivce = container.Resolve<IServices>();
            var result = serivce.GetMenus();
            var str = JsonConvert.SerializeObject(result);

            Debug.WriteLine(str);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void TestMethod3()
        {
            var container = init();
            var serivce = container.Resolve<IServices>();
            var result = serivce.Insert(new PetaPoco.SystemMenu {
                Id= DateTime.Now.Ticks,
                AppId = 1,
                MenuName="BBB"
            });
            Assert.IsNotNull(result);
        }
    }
}
