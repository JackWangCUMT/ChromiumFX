// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.


public class CefStructPtrPtrType : ApiType {
    public readonly CefStructPtrType StructPtr;
    public readonly CefStructType Struct;

    public readonly string Indirection;

    public CefStructPtrPtrType(CefStructPtrType structPtr, string Indirection)
        : base(AddIndirection(structPtr.Name, Indirection)) {
        this.StructPtr = structPtr;
        this.Struct = structPtr.Struct;
        this.Indirection = Indirection;
    }

    protected CefStructPtrPtrType(CefStructPtrPtrType structPtrPtr)
        : this(structPtrPtr.StructPtr, structPtrPtr.Indirection) {
    }

    public override string OriginalSymbol {
        get { return AddIndirection(Struct.OriginalSymbol, Indirection); }
    }

    public override string PInvokeSymbol {
        get { return "IntPtr"; }
    }

    public override string[] ParserMatches {
        get { return new string[] { Struct.ParserMatches[0] + Indirection, Struct.ParserMatches[1] + Indirection }; }
    }

    public override bool IsCefStructPtrPtrType {
        get { return true; }
    }

    public override CefStructPtrPtrType AsCefStructPtrPtrType {
        get { return this; }
    }
}