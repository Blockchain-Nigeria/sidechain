﻿// Copyright 2015 Coinprism, Inc.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Openchain.BitcoinGateway
{
    public class InboundTransaction
    {
        public InboundTransaction(string transactionHash, int outputIndex, string asset, long amount, string address)
        {
            this.TransactionHash = transactionHash;
            this.OutputIndex = outputIndex; 
            this.Asset = asset;
            this.Amount = amount;
            this.Address = address;
        }

        public string TransactionHash { get; }

        public int OutputIndex { get; }

        public string Asset { get; }

        public long Amount { get; }

        public string Address { get; }
    }
}
