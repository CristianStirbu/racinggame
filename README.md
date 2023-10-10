# racinggame

Games name: UmbraKart 
Name: Cristian Stirbu
Unity Verson: 2022.3.9f1

when starting up the program the secene your suppose to start at is "Mainmenu", player 1 is the yellow car that is controled by WASD and player 2 is the red car controid by the up,down,rigt,left arrow keys. This game is a racing game you control your player to go from the beging of the level to the finnish line and once you hit the finnish line you get transportet to the next level. If you press the escape butten you paouse the game.

One of the biggest problems i had was that the car go throw the walls if they were to fast, but with the help of the mentor i found out the problem was that visual studio had its own colloin detector as well as unity so what i did was made a Rigitbody that i called "rb" and did rb.velocity = move*speed. witch fixst it by velocity of the rigitbody the represents the change of the rigitbodys position. While move being the vector 3 and "speed" a public float. A way to use math in programing is with the vector 3 with the x and z movment of the player so that thier x and z value would cgange with the players input. One thing i did was use debug.log to make sure things worked like for expamle i made a debug log for when the player hits the quit option for the main menu. I did alos use some basic math for the speed boost by having it so when the player collides with the object the player speed would me the players current speed + 20. With the level transition i made a script that had it if the object the script is assint to with the gametag "player" and if the scene was smaller or equal to 2 then in would load the next level. Also whens it is on level 3 then when the player hits the transition they will be sent back to the main menue. 

the sources i used for this project are: 

for 3D movment as well as rotaion i used this video https://www.youtube.com/watch?v=xF19LIYfUmY&t=713s 
for maiking the main menu https://www.youtube.com/watch?v=zc8ac_qUXQY
and for creating a pause screen https://www.youtube.com/watch?v=JivuXdrIHK0 
