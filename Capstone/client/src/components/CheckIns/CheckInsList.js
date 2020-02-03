import React, {Component} from "react";
import { Link} from 'react-router-dom';
import APIManager from "../../API/APIManager";
import CheckInCard from './CheckInCard';


 export default class CheckInList extends Component {
    state = {
        AllCheckIns:[]
    }

    componentDidMount() {
         APIManager.getData('CheckIns').then((checkIns) => { this.setState({    
                AllCheckIns: checkIns
            })
       })
        }

    render() {
        return (
            <>
                <div>
                    <h1>CheckIns</h1>
                    <Link to={`CheckIns/New`}><button>New CheckIn</button></Link>
                    {this.state.AllCheckIns.map(checkIns => (
                        <CheckInCard key={checkIns.id} checkIn={checkIns} {...this.props} />
                    ))}
                         
                </div>
            </>
        )
    }
}
