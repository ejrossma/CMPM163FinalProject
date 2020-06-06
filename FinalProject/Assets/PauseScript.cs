using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    void OnGUI() {
        // show a 'pause' button
        if(GUI.Button(Rect(0,0,120,30),"TOGGLE PAUSE")){
            // call our toggle function
            doPauseToggle();
        }
        // show a 'slowmo' button
        if(GUI.Button(Rect(0,30,80,30),"SLOWMO")){
        // call our toggle function
            slowMo();
        }
    }
    void doPauseToggle() {
        // here we check to see if we are running at a time scale above 0
        if(Time.timeScale>0){
            // time scale is above zero, so we need to pause the game here
            pauseGame();
        } else {
            // time scale was less than zero, so we unpause the game here
            unPauseGame();
        }
    }
    void pauseGame () {
        // set scale at which time passes to 0, freezing time(!)
        Time.timeScale=0;
        }
    void unPauseGame () {
        // set scale at which time passes to 1, running at realtime again
        Time.timeScale=1;
    }
    void slowMo () {
    // set scale at which time 5asses to 0.1, running in slowmo
    Time.timeScale=0.1;
    }
