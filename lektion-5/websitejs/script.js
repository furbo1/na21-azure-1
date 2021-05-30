const getCustomers = () => {
    fetch('https://url.com/api/customers').then(res => res.json()).then(data => {
       console.log(data)
    })
    .catch(error => console.log(error))
}

const createCustomer = (customer) => {
    fetch('https://url.com/api/customers', {
        method: 'post',
        headers: {
            "ContentType":"application/json"
        },
        body: customer
    })
    .catch(error => console.log(error))
}


const onSubmit = (event) => {
    event.preventDefault();

    let customer = {
        firstName: event.target['firstName'].value,
        lastName: event.target['lastName'].value,
        email: event.target['email'].value
    }

    let json = JSON.stringify(customer)

    createCustomer(json);
}