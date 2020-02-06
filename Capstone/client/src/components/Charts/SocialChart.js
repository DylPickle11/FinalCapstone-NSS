import React, { Component } from 'react';
import Chart from 'chart.js';
import APIManager from '../../API/APIManager';
//import classes from "./LineGraph.module.css";



export default class SocialChart extends Component {
    state = {
        WeekCheckIns:[]
    }

    componentDidMount() {
        APIManager.getWeekData('CheckIns').then((checkIns) => { this.setState({    
               WeekCheckIns: checkIns
           })
      })
       }
    chartRef = React.createRef();
    
    componentDidMount() {
        const myChartRef = this.chartRef.current.getContext("2d");
        APIManager.getWeekData('CheckIns').then((checkIns) => { this.setState({    
            WeekCheckIns: checkIns
        })
   })
        
        new Chart(myChartRef, {
            type: "pie",
            data: {
                //Bring in data
                labels: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"],
                datasets: [
                    {
                        label: "Sales",
                        data: [86, 67, 91],
                    }
                ]
            },
            options: {
                //Customize chart options
            }
        });
    }
    render() {
        return (
            <div >
                <canvas
                    id="myChart"
                    ref={this.chartRef}
                />
            </div>
        )
    }
}