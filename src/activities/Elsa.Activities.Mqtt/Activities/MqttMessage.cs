using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsa.Activities.Mqtt.Activities
{
    public record MqttMessage ( string Topic, string Payload);
}
