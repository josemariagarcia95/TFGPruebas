﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmotionAPI_WPF_Samples.MyEmotions
{
    class Disgust:_Emotion
    {
        public Disgust(double score) : base("Disgust", score)
        {
        }

        public override string compare_emotions(_Emotion emotion)
        {
            throw new NotImplementedException();
        }

        public override string compare_emotions(_Emotion emotion1, _Emotion emotion2)
        {
            throw new NotImplementedException();
        }
    }
}