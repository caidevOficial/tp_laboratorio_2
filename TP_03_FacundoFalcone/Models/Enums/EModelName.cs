/*
 * MIT License
 * 
 * Copyright (c) 2021 [FacuFalcone]
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Enums {

    /// <summary>
    /// The number represents the amount of each kind of 
    /// materials used to manufacture each piece of the robot
    /// </summary>
    public enum EModelName {
        WallE = 60,             // Each Piece: 360    Total Materials: 1.8K
        C3PO = 200,             // Each Piece: 1200   Total Materials: 7.2K
        T800 = 500,             // Each Piece: 3000   Total Materials: 18K
        OptimusPrime = 2000,    // Each Piece: 12000  Total Materials: 72K
        Megatron = 2200,        // Each Piece: 13200  Total Materials: 79.2K
        Eva01 = 2500,           // Each Piece: 15000  Total Materials: 90K
        DragonZord = 2750,      // Each Piece: 19250  Total Materials: 115.5K
        BladeLiger = 3250,      // Each Piece: 22750  Total Materials: 136.5K
        Mugendramon = 3500      // Each Piece: 24500  Total Materials: 147K
    }
}
