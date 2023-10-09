# racinggame

Games name: UmbraKart 

when starting up the program the secene your suppose to start at is "Mainmenu"

One of the biggest problems i had was that the car go throw the walls if they were to fast, but with the help of the mentor i found out the problem was that visual studio had its own colloin detector as well as unity so what i did was made a Rigitbody that i called "rb" and did rb.velocity = move*speed. witch fixst it by velocity of the rigitbody the represents the change of the rigitbodys position. While move being the vector 3 and "speed" a public float. A way to use math in programing is with the vector 3 with the x and z movment of the player so that thier x and z value would cgange with the players input. One thing i did was use debug.log to make sure things worked like for expamle i made a debug log for when the player hits the quit option for the main menu. 
the sources i used for this project are: 

for 3D movment as well as rotaion i used this video https://www.youtube.com/watch?v=xF19LIYfUmY&t=713s 
for maiking the main menu https://www.youtube.com/watch?v=zc8ac_qUXQY
and for creating a pause screen https://www.youtube.com/watch?v=JivuXdrIHK0 

assests: this are the assests i got from unity asset store for the game https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085 
