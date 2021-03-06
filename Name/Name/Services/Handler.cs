﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Handler : IHandler
    {
        IRead _readNames;
        IOutput _outputNames;
        ISort _sorter;
        IWrite _writer;

        public Handler(IRead readNames, IOutput outputNames, ISort sorter, IWrite writer)
        {
            _readNames = readNames;
            _sorter = sorter;
            _writer = writer;
            _outputNames = outputNames;
        }

        public void Start()
        {
            List<Name> unsortedNames = new List<Name>();
            _readNames.ReadData(unsortedNames);
            List<Name> sortedNames = _sorter.Sorting(unsortedNames);
            _writer.WriteData(sortedNames);
            _outputNames.ConsoleOutput(sortedNames);            
        }
    }
}
