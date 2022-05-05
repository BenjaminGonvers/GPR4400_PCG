using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PaintRoomScript : MonoBehaviour
{
    [SerializeField] private Tilemap floor;
    [SerializeField] private RuleTile tile;
    [SerializeField] private MapScript map;
    

    public void PaintAllRoom()
    {
        foreach (var mapNode in map.mapNodes)
        {
            var sizeRoom = mapNode.sizeRoom;
            sizeRoom -= new Vector2Int(2, 2);
            
            for (int iX = 0; iX < sizeRoom.x; iX++)
            {
                for (int iY = 0; iY < sizeRoom.y; iY++)
                {
                    Vector3 centerNode = mapNode.transform.position;
                    
                    Vector2Int cellpostion = new Vector2Int((int)centerNode.x - sizeRoom.x / 2 +iX,(int) centerNode.y - sizeRoom.y / 2 +iY);

                    PaintCell(cellpostion);
                }
            }
            
        }
        
    }


    private void PaintCell(Vector2Int position)
    {
       var posInGrid = floor.WorldToCell(new Vector3(position.x, position.y, 0));
        floor.SetTile(posInGrid, tile);
    }

    public void ClearMap()
    {
        floor.ClearAllTiles();
    }
    
}
