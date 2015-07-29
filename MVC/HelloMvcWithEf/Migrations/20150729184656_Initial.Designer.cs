using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Fancy.HelloMvc;

namespace HelloMvcWithEfMigrations
{
    [ContextType(typeof(ValuesContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150729184656_Initial"; }
        }

        public override string ProductVersion
        {
            get { return "7.0.0-beta6-13815"; }
        }

        public override void BuildTargetModel(ModelBuilder builder)
        {
            builder
                .Annotation("ProductVersion", "7.0.0-beta6-13815")
                .Annotation("SqlServer:ValueGenerationStrategy", "IdentityColumn");

            builder.Entity("Fancy.HelloMvc.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Val");

                    b.Key("Id");
                });
        }
    }
}
