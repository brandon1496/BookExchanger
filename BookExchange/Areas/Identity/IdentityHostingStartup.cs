/*
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BookExchange.Models;


//[assembly: HostingStartup(typeof(BookExchange.Areas.Identity.IdentityHostingStartup))]
namespace BookExchange.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<BookExchangeContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("BookExchangeContextConnection")));

                services.AddDefaultIdentity<BookExchangeUser>()
                    .AddEntityFrameworkStores<BookExchangeContext>();
            });
            
        }
    }
}
*/