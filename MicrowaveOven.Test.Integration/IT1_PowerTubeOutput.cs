using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicrowaveOvenClasses.Boundary;
using MicrowaveOvenClasses.Interfaces;
using NUnit.Framework;

namespace MicrowaveOven.Test.Integration
{
    [TestFixture]
    public class IT1_PowerTubeOutput
    {
        private IOutput _output;
        private IPowerTube _uut;

        [SetUp]
        public void SetUp()
        {
            _output = new Output();
            _uut = new PowerTube(_output);
        }

        [TestCase(50)]
        public void TurnOn_PowerOK_Allowed(int power)
        {
            _uut.TurnOn(power);
            
        }
    }
}
