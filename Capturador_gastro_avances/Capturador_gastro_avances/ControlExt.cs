using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capturador_gastro_avances
{
    public static class ControlExt
    {
        public static IEnumerable<Control> ControlsInTabOrder(this Control parent)
        {
            for
            (
              Control control = parent.GetNextControl(null, true);
              control != null;
              control = parent.GetNextControl(control, true)
            )
            {
                yield return control;
            }
        }
    }
}
