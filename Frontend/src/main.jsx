import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App/App.jsx'
import './index.css'
import { BrowserRouter as Router, Route, Routes  } from 'react-router-dom'
import addToMeal from './addToMeal/AddToMeal.jsx'
import ErrorDatabase from './ErrorDatabase.jsx'

ReactDOM.createRoot(document.getElementById('root')).render(
  <React.StrictMode>
    <Router>
      <Routes >
        <Route path="/" Component={App}/>
        <Route path='/addToMeal/:id' Component={addToMeal}/>
        <Route path='/error' Component={ErrorDatabase}/>

      </Routes >
    </Router>
  </React.StrictMode>,
)
