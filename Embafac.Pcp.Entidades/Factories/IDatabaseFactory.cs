using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embafac.Pcp.Entidades
{
    /// <summary>
    /// Defines the methods that are required for a DatabaseFactory instance.
    /// </summary>
    public interface IDatabaseFactory
    {
        /// <summary>
        /// Returns a concrete instance of the OpendeskDb data context
        /// </summary>
        /// <returns>DbContext (OpendeskDb)</returns>
        EmbafacContext Get();
    }
}
