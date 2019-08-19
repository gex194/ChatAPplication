namespace ChatApplication.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ChatApplication.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.ChatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.ChatContext context)
        {

        }
    }
}
