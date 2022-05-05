using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkScript : MonoBehaviour
{
    [SerializeField] private MapScript map;
    
    
    
    
    private MapNodeLink CreateLink(MapNode baseNode,MapNode secondNode)
    {
        
            float deltaY = baseNode.sizeRoom.y / 2 + secondNode.sizeRoom.y / 2;
            float deltaX = baseNode.sizeRoom.x / 2 + secondNode.sizeRoom.x / 2;

            var poseBaseNode = baseNode.transform.position;
            var poseSecondNode = secondNode.transform.position;

            if (poseBaseNode.x - poseSecondNode.x <= deltaX && poseBaseNode.x - poseSecondNode.x >= -deltaX)
            {
                if (poseBaseNode.y - poseSecondNode.y <= deltaY && poseBaseNode.y - poseSecondNode.y >= -deltaY)
                {
                    if (poseBaseNode.y - poseSecondNode.y <= deltaY - 5 ||
                        poseBaseNode.y - poseSecondNode.y >= -deltaY + 5)
                    {
                        GameObject newLink = new GameObject("Link node");
                        newLink.transform.parent = map.transform;

                        int sizeXtra;

                        if (poseBaseNode.y < poseSecondNode.y)
                        {
                            sizeXtra = baseNode.sizeRoom.y / 2;
                        }
                        else
                        {
                            sizeXtra = - baseNode.sizeRoom.y / 2;
                        }
                        
                        
                        
                        MapNodeLink newLinkNode = newLink.AddComponent<MapNodeLink>();
                        Vector3 posNewNode = new Vector3( (poseBaseNode.x +poseSecondNode.x) /2,sizeXtra);
                        newLinkNode.transform.position = posNewNode;

                        return newLinkNode;
                    }
                    if  (poseBaseNode.x - poseSecondNode.x <= deltaX - 5 ||
                        poseBaseNode.x - poseSecondNode.x >= -deltaX + 5)
                    {
                        GameObject newLink = new GameObject("Link node");
                        newLink.transform.parent = map.transform;

                        int sizeXtra;

                        if (poseBaseNode.x < poseSecondNode.x)
                        {
                            sizeXtra = baseNode.sizeRoom.x / 2;
                        }
                        else
                        {
                            sizeXtra = - baseNode.sizeRoom.x / 2;
                        }
                        
                        
                        
                        MapNodeLink newLinkNode = newLink.AddComponent<MapNodeLink>();
                        Vector3 posNewNode = new Vector3( sizeXtra,(poseBaseNode.y +poseSecondNode.y) /2);
                        newLinkNode.transform.position = posNewNode;

                        return newLinkNode;
                    }
                    
                }
            }
            return null;
    }
}
