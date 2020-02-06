import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import Chart from 'chart.js';
//import classes from "./LineGraph.module.css";



export default class SleepChart extends Component {
  
    chartRef = React.createRef();
    componentDidMount() {
        const myChartRef = this.chartRef.current.getContext("2d");
        let data = this.props.sleepHours
        console.log(this.props.sleepHours)
        new Chart(myChartRef, {
            type: "bar",
            data: {
                //Bring in data
                labels: ["Monday", "Tuesday", "Wednesday"],
                datasets: [
                    {
                        label: "Sleep",
                        data: data, 
                    }
                ]
            },
            options: {
                //Customize chart options
            }
        });
    }
    
    render() {
        console.log(this.props.sleepHours)
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