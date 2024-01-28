import {
  BrowserRouter as Router,
  Route,
  Routes,
} from "react-router-dom";
import RootPage from "./pages/RootPage";
import './normilize.css'
import RegisterForm from "./pages/RegisterPage";
import AuthPage from "./pages/AuthPage";

function App() {
  return (
    <div className="App">
      <Router>
        <Routes>
          <Route exact path="/" element={<RootPage/>}></Route>
          <Route exact path="/SignUp" element={<RegisterForm/>}></Route>
          <Route exact path="/login" element={<AuthPage/>}></Route>
        </Routes>
      </Router>
    </div>
  );
}
export default App;
