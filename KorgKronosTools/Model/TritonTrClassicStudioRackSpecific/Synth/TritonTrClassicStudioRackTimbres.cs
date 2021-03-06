﻿// (c) Copyright 2011-2019 MiKeSoft, Michel Keijzers, All rights reserved


using PcgTools.Model.Common.Synth.PatchCombis;
using PcgTools.Model.TritonSpecific.Synth;

namespace PcgTools.Model.TritonTrClassicStudioRackSpecific.Synth
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class TritonTrClassicStudioRackTimbres : TritonTimbres
    {
        /// <summary>
        /// 
        /// </summary>
        static int TimbresOffsetConstant => 224;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="combi"></param>
        public TritonTrClassicStudioRackTimbres(ICombi combi)
            : base(combi, TimbresOffsetConstant)
        {
            for (var n = 0; n < TimbresPerCombi; n++)
            {
                TimbresCollection.Add(new TritonTrClassicStudioRackTimbre(this, n));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        protected override ITimbre CreateNewTimbre(int index)
        {
            return new TritonTrClassicStudioRackTimbre(this, index);
        }

    }
}
