﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using AttackSurfaceAnalyzer.Types;
using CommandLine;
using System.Collections.Generic;
using System.ComponentModel;

namespace AttackSurfaceAnalyzer.Objects
{

    public class Rule
    {
        public List<PLATFORM> Platforms { get; set; } = new List<PLATFORM>() { PLATFORM.LINUX, PLATFORM.MACOS, PLATFORM.WINDOWS };

        public List<CHANGE_TYPE> ChangeTypes { get; set; } = new List<CHANGE_TYPE>() { CHANGE_TYPE.CREATED, CHANGE_TYPE.DELETED, CHANGE_TYPE.MODIFIED };

        public string Name { get; set; }
        public string? Description { get; set; }
        public ANALYSIS_RESULT_TYPE Flag { get; set; }
        public RESULT_TYPE ResultType { get; set; }
        public List<Clause> Clauses { get; set; } = new List<Clause>();

        public Rule(string NameIn)
        {
            Name = NameIn;
        }
    }

    public class Clause
    {
        public string Field { get; set; }
        public OPERATION Operation { get; set; }

        public List<string>? Data { get; set; }
        public List<KeyValuePair<string, string>>? DictData { get; set; }

        public Clause(string FieldIn)
        {
            Field = FieldIn;
        }
    }
}
