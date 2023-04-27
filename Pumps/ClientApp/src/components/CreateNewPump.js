import React, { Component } from 'react';
import Form from 'react-bootstrap/Form';
import Button from 'react-bootstrap/Button';

export class CreateNewPump extends Component {
  static displayName = CreateNewPump.name;

  /*constructor(props) {
    super(props);
    }*/
  
  render() {
      return (
          
          <Form>
              <Form.Group className="mb-3" controlId="formBasicEmail">
                  <Form.Label>Part number</Form.Label>
                  <Form.Control type="number" placeholder="Enter Pump part number"/>
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
                  <Form.Control type="number" placeholder="Enter price" />
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
              
              <Button variant="primary" type="submit" className = "mt-5" >
                  Submit
              </Button>
          </Form>
      
    );
  }
}
