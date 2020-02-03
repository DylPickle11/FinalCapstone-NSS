import React, { Component } from 'react';
import APIManager from '../../API/APIManager';



export default class CheckInForm extends Component {
    state = {
        userId: this.props.userId,
        dateCreated: this.props.dateCreated,
        description: "",
        sleepHours: 0,
        sleepQualities: [],
        sleepQualityId: 0,
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


    constructNewCheckIn = evt =>{
        evt.preventDefault();
        const newCheckIn ={
            userId: this.props.userId,
            dateCreated: this.props.dateCreated,
            description: "",
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
        APIManager.postData("CheckIns", newCheckIn)
        console.log(newCheckIn)
    } 




    componentDidMount() {
        console.log(this.props)
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
                        SleepHours: <input type='number' id="sleepHours" onChange={this.handlefieldChange} />
                        <br />
                        <select id="sleepQuality" onChange={this.handlefieldChange}>
                            {this.state.sleepQualities.map(sleep =>
                                <option key={sleep.id} value={sleep.id}>{sleep.sleepQualityType}</option>
                            )}
                        </select>
                        <br />
                        Meals: <input type='number'  id="meals" onChange={this.handlefieldChange}/>
                        <br/>
                        <select id="emotion" onChange={this.handlefieldChange}>
                            {this.state.emotions.map(emo =>
                                <option key={emo.id} value={emo.id}>{emo.emotionType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="energy" onChange={this.handlefieldChange}>
                            {this.state.energies.map(ener =>
                                <option key={ener.id} value={ener.id}>{ener.energyType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="motivation" onChange={this.handlefieldChange}>
                            {this.state.motivations.map(mot =>
                                <option key={mot.id} value={mot.id}>{mot.motivationType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="attention" onChange={this.handlefieldChange}>
                            {this.state.attentions.map(att =>
                                <option key={att.id} value={att.id}>{att.attentionType}</option>
                            )}
                        </select>
                        <br />
                        <select  id="social" onChange={this.handlefieldChange}>
                            {this.state.socials.map(soc =>
                                <option key={soc.id} value={soc.id}>{soc.socialType}</option>
                            )}
                        </select>
                        <br />
                        Exercise Hours: <input type='number'  id="exerciseHours" onChange={this.handlefieldChange}/>
                        <br />
                        <button type="button" onClick={this.constructNewCheckIn}>Submit</button>
                    </form>

                </div>
            </>
        )
    }
}