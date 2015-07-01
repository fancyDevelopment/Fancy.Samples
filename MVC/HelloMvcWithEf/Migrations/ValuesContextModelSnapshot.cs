using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Fancy.HelloMvc;

namespace Fancy.HelloMvc.Migrations
{
    [ContextType(typeof(ValuesContext))]
    partial class ValuesContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("Fancy.HelloMvc.Value", b =>
                    {
                        b.Property<int>("Id")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0)
                            .Annotation("SqlServer:ValueGeneration", "Default");
                        b.Property<string>("Val")
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("Id");
                    });
                
                return builder.Model;
            }
        }
    }
}
