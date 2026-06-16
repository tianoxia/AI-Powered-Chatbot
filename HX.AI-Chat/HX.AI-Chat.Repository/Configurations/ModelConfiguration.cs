using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HX.AI_Chat.Dto.Enums;
using HX.AI_Chat.Entity;

namespace HX.AI_Chat.Repository.Configurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            var dateCreated = new DateTime(2025, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var userId = Guid.Parse("5f7ab694-1b6c-4b19-badd-c82b65e794cf");
            builder.HasData(
                new Model
                {
                    Id = new("c36e22ed-262a-47a1-b2ba-06a38355ae0f"),
                    Name = "llama3.2",
                    IsToolEnabled = true,
                    Description = "Llama 3.2 - Meta's latest open-source model, balanced performance for general tasks.",
                    DateCreated = dateCreated,
                    DateModified = dateCreated,
                    CreatedById = userId,
                    ModifiedById = userId
                },
                new Model
                {
                    Id = new("fd01b615-1e9f-46af-957f-e4eaeff02766"),
                    Name = "llama3.1",
                    IsToolEnabled = true,
                    Description = "Llama 3.1 - Powerful model for complex reasoning and code generation.",
                    DateCreated = dateCreated,
                    DateModified = dateCreated,
                    CreatedById = userId,
                    ModifiedById = userId
                },
                new Model
                {
                    Id = new("0b3948f5-70df-4697-a033-ae70971e1796"),
                    Name = "qwen2.5",
                    IsToolEnabled = true,
                    Description = "Qwen 2.5 - Fast and efficient model optimized for quick responses.",
                    DateCreated = dateCreated,
                    DateModified = dateCreated,
                    ModifiedById = userId,
                    CreatedById = userId
                }
            );
        }
    }
}