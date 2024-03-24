import React, { useState } from "react";
import { Link } from "react-router-dom";
import { Footer, Navbar } from "../components";
import { useNavigate } from "react-router-dom";
import { postLogin } from "../services/apiService";
import { useDispatch } from "react-redux";
const Login = (props) => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const nagivate = useNavigate();
  const dispatch = useDispatch();
  const handleLogin = async () => {
    let res = await postLogin(email, password);
    if (res && res.data.success === true) {
      dispatch({
        type: 'FETCH_USER_LOGIN_SUCCESS',
        payload: res.data
      })
      nagivate("/")
      console.log('concac');
      console.log(res.data)
    } else {
      console.log('check res', res.data.success)
    }
  }
  return (
    <>
      <Navbar />
      <div className="container my-3 py-3">
        <h1 className="text-center">Login</h1>
        <hr />
        <div class="row my-4 h-100">
          <div className="col-md-4 col-lg-4 col-sm-8 mx-auto">
            <form>
              <div class="my-3">
                <label for="display-4">Email address</label>
                <input
                  type="email"
                  class="form-control"
                  id="floatingInput"
                  placeholder="name@example.com"
                  value={email}
                  onChange={(event) => setEmail(event.target.value)}
                />
              </div>
              <div class="my-3">
                <label for="floatingPassword display-4">Password</label>
                <input
                  type="password"
                  class="form-control"
                  id="floatingPassword"
                  placeholder="Password"
                  value={password}
                  onChange={(event) => setPassword(event.target.value)}
                />
              </div>
              <div className="my-3">
                <p>New Here? <Link to="/register" className="text-decoration-underline text-info">Register</Link> </p>
              </div>
              <div className="text-center" onClick={() => handleLogin()}>
                <button class="my-2 mx-auto btn btn-dark" type="submit" disabled>
                  Login
                </button>
              </div>
            </form>
          </div>
        </div>
      </div>
      <Footer />
    </>
  );
};

export default Login;
