using System;
using System.Collections.Generic;
using System.Text;
using FluentMigrator;
using ProductService.Core.Domain;

namespace ProductService.Infrastructure.Migration
{
    [Migration(20200614)]
    public class InitMigration : FluentMigrator.Migration
    {
        public override void Up()
        {
            Create.Table(nameof(Category))
                .WithColumn(nameof(Category.Id)).AsInt64().PrimaryKey().Identity()
                .WithColumn(nameof(Category.Name)).AsString();


            Create.Table(nameof(Product))
                .WithColumn(nameof(Product.Id)).AsInt64().PrimaryKey().Identity()
                .WithColumn(nameof(Product.Name)).AsString()
                .WithColumn(nameof(Product.Description)).AsString()
                .WithColumn(nameof(Product.CategoryId)).AsInt64().ForeignKey(nameof(Category), nameof(Category.Id));
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}
