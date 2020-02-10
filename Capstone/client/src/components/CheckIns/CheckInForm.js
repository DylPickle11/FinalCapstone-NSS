import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import moment from 'moment'
import {Button} from 'semantic-ui-react';



export default class CheckInForm extends Component {
     moment = moment().format("DD-MM-YYYY, hh:mm:ss a");
    state = {
        userId: this.props.userId,
        dateCreated: this.moment,
        description: "",
        sleepHours: 0,
        sleepQualities: [],
        meals: 0,
        emotions: [],
        sleepQualityId: 0,
        energies: [],
        energyId: 0,
        motivations: [],
        motivationId: 0,
        attentions: [],
        attentionId: 0,
        socials: [],
        socialId: 0,
        exerciseHours: 0
    }

    handlefieldChange= evt =>{
        const stateToChange ={}
        stateToChange[evt.target.id] = evt.target.value
        this.setState(stateToChange)
    }

    handleNumberfieldChange= evt =>{
        const stateToChange ={}
        stateToChange[evt.target.id] = +evt.target.value
        this.setState(stateToChange)
    }


    constructNewCheckIn = evt =>{
        evt.preventDefault();
        const newCheckIn ={
            userId: this.props.userId,
            dateCreated: this.state.DateCreated,
            description: this.state.description,
            sleepHours: this.state.sleepHours,
            sleepQualityId: this.state.sleepQuality,
            meals: this.state.meals,
            emotionId: this.state.emotion,
            energyId: this.state.energy,
            motivationId: this.state.motivation,
            attentionId: this.state.attention,
            socialId: this.state.social,
            exerciseHours: this.state.exerciseHours
        }
        alert("You have successfully submitted a CheckIn!")
        APIManager.postData("CheckIns", newCheckIn)
        .then(() => this.props.history.push("/CheckIns"))
    } 

    componentDidMount() {
        let sleepQualities = [];
        let emotions = [];
        let energies = [];
        let motivations = [];
        let attentions = [];

        APIManager.getData('SleepQualities')
            .then((sleep => { sleepQualities = sleep }))
            .then(() => APIManager.getData('Emotions'))
            .then((emotion => { emotions = emotion }))
            .then(() => APIManager.getData('Energies'))
            .then((energy => { energies = energy }))
            .then(() => APIManager.getData('Motivations'))
            .then((motivation => { motivations = motivation }))
            .then(() => APIManager.getData('Attentions'))
            .then((attention => { attentions = attention }))
            .then(() => APIManager.getData('Socials'))
            .then(social => {
                this.setState({
                    sleepQualities: sleepQualities,
                    emotions: emotions,
                    energies: energies,
                    motivations: motivations,
                    attentions: attentions,
                    socials: social
                })
            })
    }
    render() {
        return (
            <>
                <div>
                    <h1>CheckIn</h1>
                    <form>
                        <textarea row='10' cols='20' placeholder="How was your day?" id="description" onChange={this.handlefieldChange}></textarea>
                        <br />
                        SleepHours: <input type='number' id="sleepHours" onChange={this.handleNumberfieldChange} />
                        <br />
                        <select id="sleepQuality" onChange={this.handleNumberfieldChange}>
                            {this.state.sleepQualities.map(sleep =>
                                <option key={sleep.id} value={sleep.id}>{sleep.sleepQualityType}</option>
                            )}
                        </select>
                        <br />
                        Meals: <input type='number'  id="meals" onChange={this.handleNumberfieldChange}/>
                        <br/>
                        <select id="emotion" onChange={this.handleNumberfieldChange}>
                            {this.state.emotions.map(emo =>
                                <option key={emo.id} value={emo.id}>{emo.emotionType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="energy" onChange={this.handleNumberfieldChange}>
                            {this.state.energies.map(ener =>
                                <option key={ener.id} value={ener.id}>{ener.energyType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="motivation" onChange={this.handleNumberfieldChange}>
                            {this.state.motivations.map(mot =>
                                <option key={mot.id} value={mot.id}>{mot.motivationType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="attention" onChange={this.handleNumberfieldChange}>
                            {this.state.attentions.map(att =>
                                <option key={att.id} value={att.id}>{att.attentionType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="social" onChange={this.handleNumberfieldChange}>
                            {this.state.socials.map(soc =>
                                <option key={soc.id} value={soc.id}>{soc.socialType}</option>
                            )}
                        </select>
                        <br />
                        Exercise Hours: <input type='number'  id="exerciseHours" onChange={this.handleNumberfieldChange}/>
                        <br />
                        <Button basic color="teal" onClick={this.constructNewCheckIn}>Submit</Button>
                    </form>

                </div>
            </>
        )
    }
}