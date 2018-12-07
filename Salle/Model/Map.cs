
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Model{

    

    public class Map : IMap {

        private int height = 3;
        private int width =3;
        private int[][] map; 

        public Map() {

        }




        public void Map2() {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public void loadMap() {
            for (int i=0; i < getWidth() ;i++)
            {
                for (int j = 0; j < getHeight() ; j++)
                {
                    map[i][j] = 2;
                    Console.WriteLine(map[i][j]);
                }
            }
                    
        }

        /// <summary>
        /// @return
        /// </summary>
        public int getWidth() {
            // TODO implement here
            return width;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void setWidth(int inWidth) {
            // TODO implement here
            this.width = inWidth;

        }

        /// <summary>
        /// @return
        /// </summary>
        public int getHeight() {
            // TODO implement here
            return height;
        }

        /// <summary>
        /// @return
        /// </summary>
        public void setHeight(int inHeight) {
            this.height = inHeight;
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public void setOnTheMapXY(int Sx,int Sy) {
            // TODO implement here

        }

        /// <summary>
        /// @return
        /// </summary>
        public Element getOnTheMapXY() {
            // TODO implement here
            return null;
        }

        public void setMobileHasChanged() {
            // TODO implement here
        }

        /// <summary>
        /// @return
        /// </summary>
        public Element getElement() {
            // TODO implement here
            return getElement;
        }

    }
}