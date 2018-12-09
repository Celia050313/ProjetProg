
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model{
    public class Map : IMap {

        int height;
        int width;

        public Map() {
        }


        /// <summary>
        /// @return
        /// </summary>
        public void loadMap() {
            // TODO implement here
            return null;
        }


        public int getWidth() {
            return width;
        }


        public void setWidth(int width) {
            this.width=width;
        }


        public int getHeight() {
            return height;
        }

        public void setHeight(int height) {
            this.height=height;
        }

        /// <summary>
        /// @return
        /// </summary>
        public int setOnTheMapXY() {
            // TODO implement here
            return 0;
        }

        /// <summary>
        /// @return
        /// </summary>
        public int getOnTheMapXY() {
            // TODO implement here
            return 0;
        }

        public void setMobileHasChanged() {
            this.setChanged();
            this.notifyObservers();
        }

        /// <summary>
        /// @return
        /// </summary>
        public void getElement() {
            // TODO implement here
            return null;
        }

    }
}