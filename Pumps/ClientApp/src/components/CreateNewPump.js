import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';

export class CreateNewPump extends Component {
  static displayName = CreateNewPump.name;

  constructor(props) {
      super(props);
      this.state = {
          artivendorCode: '',
          price: '',
          selectedFile:null,
          uploadResult: {
              status: 'not uploaded'
          }
      }
      this.onInputChange = this.onInputChange.bind(this);
      this.handleSubmit = this.handleSubmit.bind(this);
      /*this.uploadFile = this.uploadFile.bind(this);*/
    }


    onInputChange(event) {
        this.setState({
            [event.target.name]: event.target.value
        });
    }

    handleSubmit(event) {
        this.sendPumpData();
    }
        onUploadChange = event => {
            this.SetState({
                selectedFile: event.target.files[0],
                selectedFileName: event.target.files[0].name
            })
        };



    async uploadFile() {
        const formData = new FotrmData();
        formData.append('file', this.state.selectedFile);

        const response = await fetch("pump/upload",
            {
                method: 'POST',
                body: formData
            });
        const data = await response.json();

        this.setState({
         uploadResult: data
        })
    }

  render() {
      return (
          
          <Form onSubmit={this.handleSubmit}>
              <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>Part number</Form.Label>
                  <Form.Control type="number" placeholder="Enter Pump part number" value={this.state.artivendorCode} name="artivendorCode" onChange={this.onInputChange} />
                  <Form.Text className="text-muted">
                      Enter pump part number
                  </Form.Text>
              </Form.Group>

              <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>Model</Form.Label>
                  <Form.Control type="text" placeholder="Enter pump Model" />
                  <Form.Text className="text-muted">
                      Enter pump model
                  </Form.Text>
              </Form.Group>

              <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>pressure</Form.Label>
                  <Form.Control type="number" placeholder="Enter pump pressure" />
                  <Form.Text className="text-muted">
                      Enter pump pressure
                  </Form.Text>
              </Form.Group>

              <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>Volume</Form.Label>
                  <Form.Control type="number" placeholder="Enter pump volume" />
                  <Form.Text className="text-muted">
                      Enter pump volume
                  </Form.Text>
              </Form.Group>

              <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>Price</Form.Label>
                  <Form.Control type="number" placeholder="Enter price" value={this.state.price} name="price" onChange={this.onInputChange} />
                  <Form.Text className="text-muted">
                      Enter price
                  </Form.Text>
              </Form.Group>

              <Form.Label>Type</Form.Label>
              <Form.Select aria-label="Select type">
                  <option>Not selected</option>
                  <option value="0">Downhole</option>
                  <option value="1">Circulation</option>
                  <option value="2">Drainage</option>
              </Form.Select>

              <Form.Group controlId="formFile" className="mt-5">
                  <Form.Label>Load picture of a new pump</Form.Label>
                  <Form.Control type="file" />
              </Form.Group>

              <div className="mt-5 d-flex">
                  <div className="custom-file w-50 mr-2">
                      <Form.Control type="file" name="file" onChange={this.onUploadChange} className="custom-file-input" />
                      <label className="custom-file-label" htmlFor="customFile"> {this.state.selectedFileName}</label>
                  </div>
                  <button type="button" className="btn btn-success" onClick={this.uploadFile}>Upload</button>
              </div>
              <p>Status: {this.state.uploadResult.status}</p>

              <Button variant="primary" type="submit" className = "mt-5" >
                  Submit
              </Button>
          </Form>
      
    );
    }

    async sendPumpData() {
        const formData = new FormData();
        formData.append("artivendorCode", this.state.artivendorCode);
        //formData.append("title", this.state.title);
        //formData.append("h", this.state.h);
        //formData.append("q", this.state.q);
        formData.append("price", this.state.price);
        //formData.append("typ", this.state.typ);
        //formData.append("filname", this.state.uploadResult.fileName);

        const response = await fetch('api/admin/pump/create',
            {
                method: 'POST',
                body: formData
            });
        const data = await response.json();
        
    }
}
