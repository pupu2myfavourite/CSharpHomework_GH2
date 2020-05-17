using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using ch12Homework_GH.models;

namespace ch12Homework_GH
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<OrderContext>(options => options
                // 连接字符串"todoDatabase" 可以在appsetting.json中设置
                .UseMySql(Configuration.GetConnectionString("orderDatabase"), 
                    mySqlOptions => mySqlOptions
                    .ServerVersion(new Version(8, 0, 17), ServerType.MySql)
            ));
            //创建控制器对象，创建时进行依赖注入
            services.AddControllers(); 
      
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //机器的环境设置为Development
                app.UseDeveloperExceptionPage();
            }
            //设置缺省静态文件（index.html或index.html）
            app.UseDefaultFiles(); 
            //启动静态文件（页面、js、图片等各种前端文件）
            app.UseStaticFiles(); 

            //启动http到https的重定向
            app.UseHttpsRedirection();
            //将路由组件添加到app中
            app.UseRouting();
            //将授权组件添加到app中
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //启动映射，将url路由到控制器
                endpoints.MapControllers();
            });
        }
    }
}
