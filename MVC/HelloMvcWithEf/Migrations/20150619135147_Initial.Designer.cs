using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using Fancy.HelloMvc;

namespace Fancy.HelloMvc.Migrations
{
    [ContextType(typeof(ValuesContext))]
    partial class Initial
    {
        public override string Id
        {
            get { return "20150619135147_Initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta4-12943"; }
        }
        
        public override IModel Target
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
