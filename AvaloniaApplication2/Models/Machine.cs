using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;


namespace AvaloniaApplication2.Models
{
    public partial class Machine:ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(TextStatus))]
        private bool _istAn;
        public string TextStatus
        {
            get
            {
                if (IstAn)
                    return "Maschine Läuft";
                else
                    return "Machine stoppt";
                
            }
        }

    }
}
