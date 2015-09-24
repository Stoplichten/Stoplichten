using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stoplichten
{
    class Controller
    {
        List<GameObject> objects;
        GameObject lastCollided;

        public Controller(List<GameObject> objects)
        {
            this.objects = objects;
        }

        public List<GameObject> checkCollision(GameObject gameObject)
        {
            List<GameObject> returnList = new List<GameObject>();

            GameObject[] array = new GameObject[objects.Count];

            objects.CopyTo(array);

            returnList = array.ToList<GameObject>();

            foreach (GameObject gObject in objects)
            {
                if (gameObject.rectangle.Intersects(gObject.rectangle) && gObject != lastCollided)
                {
                    returnList.Remove(gObject);

                    if (returnList.Count > 1)
                    {
                        returnList.Remove(lastCollided);
                    }
                    lastCollided = gObject;


                    return returnList;
                }

            }
            return null;
        }

    }
}
