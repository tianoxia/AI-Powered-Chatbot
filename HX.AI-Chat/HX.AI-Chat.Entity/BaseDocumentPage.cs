using Microsoft.Data.SqlTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace HX.AI_Chat.Entity
{
    public class BaseDocumentPage : BaseModifiedEntity
    {
        public int Number { get; set; }

        public string Text { get; set; } = null!;

        [Column(TypeName = "vector(384)")]
        public SqlVector<float> Embedding { get; set; }
    }
}
