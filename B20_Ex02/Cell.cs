﻿using System;
using System.Collections.Generic;
using System.Text;

namespace B20_Ex02
{
     class Cell
     {


          private int m_CellContent;
          private bool m_IsFlipped;
          public Pair m_Location;

          public int CellContent 
          {
               get => m_CellContent; 
               set => m_CellContent = value; 
          }
          public bool IsFlipped
          {
               get => m_IsFlipped; 
               set => m_IsFlipped= value; 
          }
          public Pair Location
          {
               get => m_Location  ; 
               set => m_Location= value; 
          }
     }
}
