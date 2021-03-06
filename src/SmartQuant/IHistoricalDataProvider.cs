﻿// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface IHistoricalDataProvider : IProvider
    {
        void Send(HistoricalDataRequest request);
        void Cancel(string requestId);
    }
}
