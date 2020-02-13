import React, { Component } from 'react';
import APIManager from '../../API/APIManager';
import { Button, Header, Form, Dropdown, Input, Message, Grid, GridRow } from 'semantic-ui-react';



export default class CheckInForm extends Component {

    state = {
        userId: this.props.userId,
        dateCreated: this.moment,
        description: "",
        sleepHours: 0,
        sleepQualities: [],
        meals: 0,
        emotions: [],
        sleepQualityId: "",
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

    handlefieldChange = evt => {
        const stateToChange = {}
        stateToChange[evt.target.id] = evt.target.value
        this.setState(stateToChange)
    }
    
    handleNumberfieldChange = (evt,{ id, value}) => { this.setState({[id]: +value})}


    constructNewCheckIn = evt => {
 
        evt.preventDefault();
        const newCheckIn = {
            userId: this.props.userId,
            dateCreated: this.state.DateCreated,
            description: this.state.description,
            sleepHours: this.state.sleepHours,
            sleepQualityId: this.state.sleepQualityId,
            meals: this.state.meals,
            emotionId: this.state.emotionId,
            energyId: this.state.energyId,
            motivationId: this.state.motivationId,
            attentionId: this.state.attentionId,
            socialId: this.state.socialId,
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
        let socials = [];

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
            .then((social => {socials = social }))
            .then(()=> {
                this.setState({
                    sleepQualities: sleepQualities,
                    emotions: emotions,
                    energies: energies,
                    motivations: motivations,
                    attentions: attentions,
                    socials: socials
                })
            })
    }

    sleepQuality = () => {
        let sleepOption = []
        this.state.sleepQualities.map(sleep => {
            let sleepObj = {key: sleep.id.toString(), text: sleep.sleepQualityType, value: sleep.id }
            sleepOption.push(sleepObj)
        })
       
        return sleepOption
    }
    emotion = () => {
        let emotionOption = []
        this.state.emotions.map(emotion => {
            let emotionObj = { key: emotion.id, text: emotion.emotionType, value: emotion.id }
            emotionOption.push(emotionObj)
        })
        return emotionOption
    }
    energy = () => {
        let energyOption = []
        this.state.energies.map(energy => {
            let energyObj = { key: energy.id, text: energy.energyType, value: energy.id }
            energyOption.push(energyObj)
        })
        return energyOption
    }
    motivation = () => {
        let motivationOption = []
        this.state.motivations.map(motivation => {
            let motivationObj = { key: motivation.id, text: motivation.motivationType, value: motivation.id }
            motivationOption.push(motivationObj)
        })
        return motivationOption
    }
    attention = () => {
        let attentionOption = []
        this.state.attentions.map(attention => {
            let attentionObj = { key: attention.id, text: attention.attentionType, value: attention.id }
            attentionOption.push(attentionObj)
        })
        return attentionOption
    }
    social = () => {
        let socialOption = []
        this.state.socials.map(social => {
            let socialObj = { key: social.id, text: social.socialType, value: social.id }
            socialOption.push(socialObj)
          
        })
        return socialOption
    }

    render() {
        return (
            <>
                <Header as='h1'>CheckIn</Header>
                <Form className='formContainer'>
                   
                <div className="description">
                        <Form.Field className="ten wide field">
                            <label>Day Description</label>
                            <textarea row='10' cols='20' placeholder="Tell us about your day?" className="description" onChange={this.handlefieldChange}></textarea>
                        </Form.Field>
                   </div>
                        <Grid columns={3}>
                        <Grid.Row>
                            <Grid.Column>
                                <Form.Field className="eleven wide field">
                                    <label>Sleep Hours</label>
                                    <Input type='number' placeholder="sleepHours" id="sleepHours" onChange={this.handleNumberfieldChange} />
                                </Form.Field>
                                <Form.Field className="ten wide field">
                                    <label>Sleep Quality</label>
                                    <Dropdown selection placeholder="Sleep Quality" id="sleepQualityId" name='sleepQualityId' onChange={this.handleNumberfieldChange} options={this.sleepQuality()} />
                                </Form.Field>
                                <Form.Field className="ten wide field">
                                    <label>Emotion</label>
                                    <Dropdown selection placeholder="Emotion" id="emotionId" onChange={this.handleNumberfieldChange} options={this.emotion()} />
                                </Form.Field>
                            </Grid.Column>
                        


                        <Grid.Column>
                         
                                <Form.Field className="ten wide field">
                                    <label>Energy Level</label>
                                    <Dropdown selection placeholder="Energy Level" id="energyId" onChange={this.handleNumberfieldChange} options={this.energy()} />
                                </Form.Field>
                           
                         
                                <Form.Field className="ten wide field">
                                    <label>Motivation Level</label>
                                    <Dropdown selection placeholder="Motivation" id="motivationId" onChange={this.handleNumberfieldChange} options={this.motivation()} />
                                </Form.Field>
                        
                      
                                <Form.Field className="ten wide field">
                                    <label>Attention Level</label>
                                    <Dropdown selection placeholder="Attention" id="attentionId" onChange={this.handleNumberfieldChange} options={this.attention()} />
                                </Form.Field>
                       
                        </Grid.Column>

                        <Grid.Column> 
                            <Form.Field className="ten wide field">
                                <label>Social Level</label>
                                <Dropdown selection placeholder="Social" id="socialId" onChange={this.handleNumberfieldChange} options={this.social()} />
                            </Form.Field>
                            <Form.Field className="eleven wide field">
                                <label>Amount of Meals</label>
                                <Input type='number' placeholder="" id="meals" onChange={this.handleNumberfieldChange} />
                            </Form.Field>
                            <Form.Field className="eleven wide field">
                                <label>Exercise Hours</label>
                                <Input type='number' placeholder="Exercise Hours" id="exerciseHours" onChange={this.handleNumberfieldChange} />
                            </Form.Field>
                            </Grid.Column>
                            <div className="button">   
                            <Button className="button" basic color="purple" size="medium" onClick={this.constructNewCheckIn}>Submit</Button>
                            </div>
                        </Grid.Row>
                        
                    </Grid>
                </Form>
            </>
        )
    }
}