# Slightly Color Changing System
 Change material color and light color (light color more translucent)slightly on every trigger.
 I use this system at one of my games [click for see](https://play.google.com/store/apps/details?id=com.YeasWorld.FitIt)
 
<img align="right" alt="GIF" src="https://github.com/TahaMetin/Slightly-Color-Changing-System/blob/main/slightly color changing example.gif"/>
 
## Material color RGB numbers cycle:

R 	 G  	B

250	000 000        
250	000 **250**        
**000** 000 250        
000 **250**	250	        
000 250	**000**   
**250**	250	000      
250 **000** 000       

In my case i set it to start over in 100 steps. so :        

250 * 6 = 1500        

1500 / 100 = 15        
 
 
## Light color RGB numbers cycle:        
 
R	  G	  B        

250	200	200        
250	200	**250**        
**200**	200	250        
200	**250**	250        
200	250	**200**        
**250**	250	200        
250	200	200        

50 * 6 = 300        
300 / 100 = 3        

