using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReviewer.Domain.Models
{
    public interface ISwitchable
    {
        void UtilizeState(object state);
    }
}
